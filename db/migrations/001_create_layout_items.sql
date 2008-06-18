-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (score, state, level) VALUES (1.44, 'stable', 17);
INSERT INTO layout_items (score, state, level) VALUES (44.91, 'blue', 67);
INSERT INTO layout_items (score, state, level) VALUES (43.03, 'green', 20);
