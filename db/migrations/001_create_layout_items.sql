-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, score) VALUES ('standard', 60.37);
INSERT INTO layout_items (state, score) VALUES ('legacy', 94.41);
INSERT INTO layout_items (state, score) VALUES ('stable', 29.7);
