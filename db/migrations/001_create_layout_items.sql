-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (score, level, state, weight) VALUES (9.37, 92, 'stable', 90.35);
INSERT INTO layout_items (score, level, state, weight) VALUES (43.64, 42, 'primary', 3.28);
INSERT INTO layout_items (score, level, state, weight) VALUES (70.96, 65, 'blue', 44.73);
