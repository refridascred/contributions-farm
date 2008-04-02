-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (rank, weight, state, token, active) VALUES (70, 90.09, 'fallback', 'open', 34);
INSERT INTO layout_items (rank, weight, state, token, active) VALUES (19, 20.49, 'fallback', 'edge', 91);
INSERT INTO layout_items (rank, weight, state, token, active) VALUES (60, 92.51, 'strict', 'primary', 74);
