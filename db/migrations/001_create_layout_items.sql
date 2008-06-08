-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, ratio, weight) VALUES ('eu-west', 53.12, 65.27);
INSERT INTO layout_items (label, ratio, weight) VALUES ('green', 83.59, 50.51);
