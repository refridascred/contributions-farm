-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (score, state, count) VALUES (10.54, 'stable', 36);
INSERT INTO layout_items (score, state, count) VALUES (55.91, 'fallback', 56);
INSERT INTO layout_items (score, state, count) VALUES (83.01, 'standard', 3);
