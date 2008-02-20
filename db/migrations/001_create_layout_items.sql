-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (state, weight) VALUES ('fallback', 66.83);
INSERT INTO layout_items (state, weight) VALUES ('fallback', 94.57);
INSERT INTO layout_items (state, weight) VALUES ('green', 57.29);
