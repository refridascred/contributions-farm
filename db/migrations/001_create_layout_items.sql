-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (ratio, state, active) VALUES (73.31, 'cached', 54);
INSERT INTO layout_items (ratio, state, active) VALUES (98.34, 'latest', 46);
INSERT INTO layout_items (ratio, state, active) VALUES (78.07, 'stable', 62);
