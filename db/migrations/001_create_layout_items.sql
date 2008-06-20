-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (level, active, label, weight) VALUES (79, 72, 'stable', 29.98);
INSERT INTO layout_items (level, active, label, weight) VALUES (27, 66, 'standard', 77.84);
INSERT INTO layout_items (level, active, label, weight) VALUES (93, 44, 'legacy', 81.79);
