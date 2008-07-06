-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    weight REAL,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (state, token, weight, rank) VALUES ('primary', 'cached', 16.13, 18);
INSERT INTO layout_items (state, token, weight, rank) VALUES ('legacy', 'legacy', 28.01, 9);
