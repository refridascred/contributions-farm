-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, ratio, state) VALUES (41, 76.92, 'eu-west');
INSERT INTO layout_items (active, ratio, state) VALUES (60, 27.87, 'legacy');
INSERT INTO layout_items (active, ratio, state) VALUES (5, 3.03, 'eu-west');
