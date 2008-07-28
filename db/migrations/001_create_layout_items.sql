-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (rank, owner, level) VALUES (91, 'primary', 16);
INSERT INTO layout_items (rank, owner, level) VALUES (12, 'eu-west', 80);
INSERT INTO layout_items (rank, owner, level) VALUES (22, 'green', 37);
