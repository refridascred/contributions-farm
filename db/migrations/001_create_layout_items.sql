-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (score, active, level, weight, state) VALUES (49.42, 13, 74, 49.77, 'legacy');
INSERT INTO layout_items (score, active, level, weight, state) VALUES (51.02, 58, 44, 16.65, 'primary');
