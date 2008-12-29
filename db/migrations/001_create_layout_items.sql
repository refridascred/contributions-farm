-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, count, region, weight, score) VALUES ('legacy', 20, 'blue', 39.89, 17.17);
INSERT INTO layout_items (label, count, region, weight, score) VALUES ('cached', 58, 'fallback', 38.91, 18.9);
