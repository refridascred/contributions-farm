-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, active) VALUES (29.66, 31);
INSERT INTO layout_items (weight, active) VALUES (12.57, 97);
INSERT INTO layout_items (weight, active) VALUES (40.07, 3);
