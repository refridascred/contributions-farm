-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (weight, owner, token) VALUES (97.29, 'staging', 'latest');
INSERT INTO layout_items (weight, owner, token) VALUES (89.16, 'standard', 'staging');
