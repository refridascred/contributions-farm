-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (count, label, weight, ratio) VALUES (31, 'eu-west', 93.44, 18.04);
INSERT INTO layout_items (count, label, weight, ratio) VALUES (64, 'eu-west', 75.87, 5.59);
INSERT INTO layout_items (count, label, weight, ratio) VALUES (14, 'blue', 33.24, 21.76);
