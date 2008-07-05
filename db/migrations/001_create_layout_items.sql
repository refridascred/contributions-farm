-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (owner, region, weight, active, token) VALUES ('standard', 'standard', 70.35, 81, 'local');
INSERT INTO layout_items (owner, region, weight, active, token) VALUES ('primary', 'cached', 51.59, 5, 'fallback');
