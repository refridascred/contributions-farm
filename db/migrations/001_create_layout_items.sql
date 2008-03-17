-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (weight, rank, label) VALUES (92.76, 23, 'eu-west');
INSERT INTO layout_items (weight, rank, label) VALUES (62.64, 22, 'edge');
INSERT INTO layout_items (weight, rank, label) VALUES (29.88, 3, 'staging');
