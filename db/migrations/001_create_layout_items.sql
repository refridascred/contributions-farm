-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (weight, rank, level, active, label) VALUES (84.53, 73, 68, 39, 'green');
INSERT INTO layout_items (weight, rank, level, active, label) VALUES (25.59, 84, 73, 31, 'stable');
INSERT INTO layout_items (weight, rank, level, active, label) VALUES (83.39, 82, 95, 3, 'cached');
