-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, level, count, active, state) VALUES (71.99, 27, 72, 16, 'open');
INSERT INTO layout_items (weight, level, count, active, state) VALUES (45.55, 93, 45, 66, 'edge');
INSERT INTO layout_items (weight, level, count, active, state) VALUES (55.94, 4, 28, 24, 'strict');
