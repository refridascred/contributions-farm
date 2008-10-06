-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, state) VALUES (67.29, 'staging');
INSERT INTO layout_items (ratio, state) VALUES (82.49, 'blue');
INSERT INTO layout_items (ratio, state) VALUES (56.23, 'standard');
