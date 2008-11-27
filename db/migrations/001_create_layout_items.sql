-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (active, score, count, weight, label) VALUES (94, 90.96, 41, 84.38, 'staging');
INSERT INTO layout_items (active, score, count, weight, label) VALUES (12, 61.75, 36, 19.13, 'primary');
INSERT INTO layout_items (active, score, count, weight, label) VALUES (57, 52.4, 87, 97.51, 'primary');
