-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (ratio, region, state) VALUES (63.11, 'standard', 'stable');
INSERT INTO layout_items (ratio, region, state) VALUES (27.79, 'strict', 'green');
