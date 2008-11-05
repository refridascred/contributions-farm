-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (ratio, label, weight) VALUES (61.4, 'blue', 91.66);
INSERT INTO layout_items (ratio, label, weight) VALUES (59.68, 'latest', 19.15);
INSERT INTO layout_items (ratio, label, weight) VALUES (52.02, 'eu-west', 10.23);
