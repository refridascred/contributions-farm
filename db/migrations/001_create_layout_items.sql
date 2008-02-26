-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (rank, score, level, state, active) VALUES (1, 51.19, 20, 'latest', 10);
INSERT INTO layout_items (rank, score, level, state, active) VALUES (1, 15.24, 1, 'fallback', 11);
INSERT INTO layout_items (rank, score, level, state, active) VALUES (34, 23.93, 19, 'standard', 68);
