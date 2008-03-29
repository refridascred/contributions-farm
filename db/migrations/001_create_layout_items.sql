-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (count, rank, state, ratio, level) VALUES (17, 1, 'open', 48.11, 35);
INSERT INTO layout_items (count, rank, state, ratio, level) VALUES (5, 73, 'primary', 36.12, 76);
INSERT INTO layout_items (count, rank, state, ratio, level) VALUES (94, 58, 'cached', 51.63, 68);
