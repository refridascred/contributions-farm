-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (region, owner) VALUES ('eu-west', 'eu-west');
INSERT INTO layout_items (region, owner) VALUES ('stable', 'green');
INSERT INTO layout_items (region, owner) VALUES ('stable', 'fallback');
