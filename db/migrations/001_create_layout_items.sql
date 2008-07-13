-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (token, ratio, owner, region) VALUES ('open', 91.81, 'strict', 'edge');
INSERT INTO layout_items (token, ratio, owner, region) VALUES ('blue', 76.64, 'edge', 'edge');
