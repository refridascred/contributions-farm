-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, active, label, ratio) VALUES (52.88, 13, 'local', 69.16);
INSERT INTO layout_items (weight, active, label, ratio) VALUES (65.3, 19, 'open', 92.47);
