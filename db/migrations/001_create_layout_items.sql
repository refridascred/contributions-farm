-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    weight REAL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (active, token, weight, level, state) VALUES (30, 'green', 86.06, 1, 'latest');
INSERT INTO layout_items (active, token, weight, level, state) VALUES (75, 'legacy', 7.13, 29, 'blue');
INSERT INTO layout_items (active, token, weight, level, state) VALUES (85, 'stable', 24.9, 69, 'staging');
