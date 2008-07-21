-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (active, level, score, state, ratio) VALUES (38, 26, 57.29, 'strict', 71.68);
