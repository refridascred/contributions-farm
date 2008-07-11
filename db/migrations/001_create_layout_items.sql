-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (level, state, weight, ratio) VALUES (85, 'blue', 39.02, 87.78);
