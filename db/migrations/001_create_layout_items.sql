-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (label, ratio, weight) VALUES ('eu-west', 26.14, 96.38);
INSERT INTO layout_items (label, ratio, weight) VALUES ('legacy', 50.69, 17.31);
INSERT INTO layout_items (label, ratio, weight) VALUES ('strict', 22.94, 55.55);
