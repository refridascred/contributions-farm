-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (weight, token, owner) VALUES (91.98, 'eu-west', 'open');
INSERT INTO layout_items (weight, token, owner) VALUES (81.84, 'blue', 'standard');
INSERT INTO layout_items (weight, token, owner) VALUES (51.01, 'strict', 'staging');
