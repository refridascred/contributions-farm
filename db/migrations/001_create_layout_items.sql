-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (token, state, rank) VALUES ('blue', 'green', 89);
INSERT INTO layout_items (token, state, rank) VALUES ('open', 'open', 41);
INSERT INTO layout_items (token, state, rank) VALUES ('fallback', 'latest', 42);
