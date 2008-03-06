-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, label, level, active) VALUES (92.1, 'open', 90, 80);
INSERT INTO layout_items (weight, label, level, active) VALUES (45.77, 'green', 31, 46);
INSERT INTO layout_items (weight, label, level, active) VALUES (60.79, 'latest', 50, 89);
