-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, active, state) VALUES (80.92, 69, 'strict');
INSERT INTO layout_items (ratio, active, state) VALUES (24.21, 21, 'staging');
INSERT INTO layout_items (ratio, active, state) VALUES (9.19, 76, 'staging');
