-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, owner, token, weight) VALUES (46.38, 'blue', 'standard', 64.13);
INSERT INTO layout_items (ratio, owner, token, weight) VALUES (36.59, 'staging', 'standard', 87.24);
