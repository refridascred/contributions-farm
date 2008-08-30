-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, active, level) VALUES (22.27, 92, 22);
INSERT INTO layout_items (weight, active, level) VALUES (48.72, 25, 54);
INSERT INTO layout_items (weight, active, level) VALUES (23.62, 51, 92);
