-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (score, state, level, label) VALUES (55.71, 'stable', 12, 'edge');
INSERT INTO layout_items (score, state, level, label) VALUES (57.66, 'standard', 73, 'fallback');
INSERT INTO layout_items (score, state, level, label) VALUES (83.63, 'blue', 44, 'cached');
