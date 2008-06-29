-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, score, state, active) VALUES (75, 28.52, 'blue', 15);
INSERT INTO layout_items (level, score, state, active) VALUES (17, 6.36, 'open', 40);
INSERT INTO layout_items (level, score, state, active) VALUES (13, 87.96, 'standard', 22);
