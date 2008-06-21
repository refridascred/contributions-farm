-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, count, state, owner) VALUES (81.11, 98, 'standard', 'standard');
INSERT INTO layout_items (score, count, state, owner) VALUES (44.0, 71, 'stable', 'standard');
INSERT INTO layout_items (score, count, state, owner) VALUES (72.82, 63, 'blue', 'local');
