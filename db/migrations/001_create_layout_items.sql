-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (region, state, ratio, token) VALUES ('edge', 'blue', 77.06, 'latest');
INSERT INTO layout_items (region, state, ratio, token) VALUES ('edge', 'green', 65.75, 'green');
