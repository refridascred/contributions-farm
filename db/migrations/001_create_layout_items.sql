-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (level, score, region) VALUES (89, 27.26, 'eu-west');
INSERT INTO layout_items (level, score, region) VALUES (17, 95.45, 'primary');
INSERT INTO layout_items (level, score, region) VALUES (69, 73.0, 'eu-west');
