-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (weight, state) VALUES (75.14, 'strict');
INSERT INTO layout_items (weight, state) VALUES (45.16, 'open');
INSERT INTO layout_items (weight, state) VALUES (41.22, 'local');
