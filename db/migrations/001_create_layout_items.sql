-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (region, active, token) VALUES ('blue', 36, 'eu-west');
INSERT INTO layout_items (region, active, token) VALUES ('latest', 53, 'staging');
INSERT INTO layout_items (region, active, token) VALUES ('strict', 80, 'blue');
