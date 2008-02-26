-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (level, active, score, state, rank) VALUES (98, 13, 21.97, 'local', 52);
INSERT INTO layout_items (level, active, score, state, rank) VALUES (84, 18, 78.19, 'latest', 16);
INSERT INTO layout_items (level, active, score, state, rank) VALUES (64, 63, 72.98, 'standard', 45);
