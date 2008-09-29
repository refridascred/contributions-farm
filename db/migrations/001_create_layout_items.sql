-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (token, ratio, owner, label, level) VALUES ('strict', 13.54, 'legacy', 'eu-west', 65);
INSERT INTO layout_items (token, ratio, owner, label, level) VALUES ('open', 76.24, 'open', 'legacy', 12);
INSERT INTO layout_items (token, ratio, owner, label, level) VALUES ('staging', 86.69, 'fallback', 'edge', 98);
