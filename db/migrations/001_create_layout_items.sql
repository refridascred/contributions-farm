-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (region, weight, owner, token) VALUES ('standard', 42.75, 'local', 'staging');
INSERT INTO layout_items (region, weight, owner, token) VALUES ('staging', 98.01, 'latest', 'local');
INSERT INTO layout_items (region, weight, owner, token) VALUES ('strict', 75.8, 'local', 'green');
