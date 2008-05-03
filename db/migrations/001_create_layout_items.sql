-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, score, state, active, level) VALUES ('staging', 73.83, 'strict', 61, 98);
INSERT INTO layout_items (owner, score, state, active, level) VALUES ('strict', 54.57, 'legacy', 49, 88);
INSERT INTO layout_items (owner, score, state, active, level) VALUES ('primary', 29.78, 'stable', 89, 76);
