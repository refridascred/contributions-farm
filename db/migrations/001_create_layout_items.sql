-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (owner, label, ratio) VALUES ('cached', 'legacy', 31.03);
INSERT INTO layout_items (owner, label, ratio) VALUES ('latest', 'blue', 94.14);
