-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, level, score, state) VALUES (60.95, 78, 86.75, 'edge');
INSERT INTO layout_items (ratio, level, score, state) VALUES (35.18, 48, 93.11, 'blue');
INSERT INTO layout_items (ratio, level, score, state) VALUES (32.79, 6, 54.96, 'fallback');
