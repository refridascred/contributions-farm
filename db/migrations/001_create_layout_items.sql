-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, ratio, label, count) VALUES ('edge', 9.99, 'standard', 63);
INSERT INTO layout_items (token, ratio, label, count) VALUES ('strict', 58.36, 'edge', 19);
INSERT INTO layout_items (token, ratio, label, count) VALUES ('strict', 75.36, 'stable', 58);
