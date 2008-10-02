-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (owner, active, state, score, level) VALUES ('blue', 99, 'open', 7.83, 61);
INSERT INTO layout_items (owner, active, state, score, level) VALUES ('green', 70, 'cached', 10.79, 31);
INSERT INTO layout_items (owner, active, state, score, level) VALUES ('primary', 2, 'open', 39.34, 43);
