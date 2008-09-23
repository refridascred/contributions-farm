-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (rank, state, token, count, active) VALUES (93, 'standard', 'fallback', 85, 26);
INSERT INTO layout_items (rank, state, token, count, active) VALUES (2, 'fallback', 'latest', 4, 1);
INSERT INTO layout_items (rank, state, token, count, active) VALUES (87, 'blue', 'cached', 90, 3);
