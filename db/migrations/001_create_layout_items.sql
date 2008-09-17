-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (label, owner, ratio) VALUES ('open', 'fallback', 80.33);
INSERT INTO layout_items (label, owner, ratio) VALUES ('eu-west', 'blue', 74.27);
INSERT INTO layout_items (label, owner, ratio) VALUES ('eu-west', 'legacy', 86.91);
