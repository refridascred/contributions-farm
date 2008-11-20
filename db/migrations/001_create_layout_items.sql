-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (score, active, token, region) VALUES (54.55, 34, 'primary', 'local');
INSERT INTO layout_items (score, active, token, region) VALUES (31.25, 34, 'open', 'cached');
INSERT INTO layout_items (score, active, token, region) VALUES (38.81, 63, 'staging', 'green');
