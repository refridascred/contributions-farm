-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, owner) VALUES ('green', 'green');
INSERT INTO layout_items (region, owner) VALUES ('eu-west', 'legacy');
INSERT INTO layout_items (region, owner) VALUES ('latest', 'strict');
