-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (score, token, region) VALUES (76.04, 'standard', 'green');
INSERT INTO layout_items (score, token, region) VALUES (63.17, 'blue', 'green');
INSERT INTO layout_items (score, token, region) VALUES (6.51, 'staging', 'stable');
