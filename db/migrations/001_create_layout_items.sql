-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (score, count, active, state, region) VALUES (62.25, 3, 36, 'cached', 'primary');
INSERT INTO layout_items (score, count, active, state, region) VALUES (94.82, 28, 77, 'local', 'cached');
INSERT INTO layout_items (score, count, active, state, region) VALUES (68.79, 94, 97, 'stable', 'blue');
