-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (score, level, state, token) VALUES (79.29, 73, 'primary', 'latest');
INSERT INTO layout_items (score, level, state, token) VALUES (16.24, 69, 'open', 'edge');
