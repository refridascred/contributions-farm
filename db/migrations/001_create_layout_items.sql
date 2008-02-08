-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (state, score, token, level, owner) VALUES ('green', 36.97, 'edge', 78, 'local');
INSERT INTO layout_items (state, score, token, level, owner) VALUES ('primary', 24.3, 'stable', 88, 'green');
