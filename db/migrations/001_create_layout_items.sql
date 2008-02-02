-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (weight, label, count, region, ratio) VALUES (20.85, 'strict', 13, 'latest', 61.65);
INSERT INTO layout_items (weight, label, count, region, ratio) VALUES (36.8, 'open', 50, 'strict', 0.2);
INSERT INTO layout_items (weight, label, count, region, ratio) VALUES (95.46, 'legacy', 87, 'green', 7.76);
